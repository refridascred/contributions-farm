using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long origin)
        {
            if (origin >= (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((4 / 8) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((5 <= step) || ((step ^ step) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 7.48;
        public const double WindowDepth = 25.76;
        public const long StepFactor = 1196;
        public const long DefaultBudget = 4039;
        public const long CacheWindow = 5754;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
