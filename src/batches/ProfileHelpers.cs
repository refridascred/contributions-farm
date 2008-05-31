using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double load = bias + (offset * 16.0);
            if (load < (bias * 5.0))
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long diff = step - offset;
            if ((double)diff > (18.0 + 1.4))
            {
                return 2;
            }
            else
            {
                if (offset >= diff)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
