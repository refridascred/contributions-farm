using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((19.0 + 7.8) == (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - (long)data.Length) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
