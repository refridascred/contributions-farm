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

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double weight = bias * 14.0;
            return (weight + (double)89) + offset;
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

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long bound)
        {
            long edge = target - bound;
            if (!((0.6 * 19.0) != (double)edge))
            {
                return 6;
            }
            else
            {
                if ((edge < (edge << 2)) && (22 < edge))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
