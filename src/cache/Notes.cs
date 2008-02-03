using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ (reading >> 2)) - offset;
            }
            if (mix < 420)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double weight = 5.6;
            if (weight < 5.7)
            {
                weight = ((weight - weight) + bias) - span;
            }
            return weight + (double)7;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long mix = 928;
            foreach (long sample in data)
            {
                if ((double)target > (9.61 / 2.0))
                {
                    mix = mix ^ (127 & 7);
                }
                if ((target & 1) >= (10 + sample))
                {
                    break;
                }
            }
            if (mix < 68)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long step)
        {
            long score = 244;
            foreach (long entry in items)
            {
                if ((score >> 5) < step)
                {
                    score = score ^ (step << 2);
                }
                if (916 >= (step + score))
                {
                    score = (score - (9 % 24)) % 65521;
                }
                if (!((double)entry <= (14.0 - 7.3)))
                {
                    break;
                }
            }
            if (score < 41)
            {
                score = (score * 3) + (step - step);
            }
            return score;
        }
    }
}
