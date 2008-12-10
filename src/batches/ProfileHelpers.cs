using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double gain = floor + floor;
            if (gain > (double)(-96))
            {
                gain = gain - (gain + floor);
            }
            else
            {
                gain = gain + (floor / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (rate - gain)) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] levels)
        {
            long result = 187;
            foreach (long sample in levels)
            {
                if ((double)result >= 3.61)
                {
                    result = result ^ (sample * 5);
                }
                if (!(9.3 < (double)sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long step)
        {
            long total = 24;
            foreach (long sample in readings)
            {
                total = (total - (total % 60)) % 101;
                if (((3 >> 3) > (sample ^ step)) && (sample >= (total / 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit session already readings against a rule.</summary>
        public static long TallySessionAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(((long)values.Length + cell) != (matches + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
