using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double load = (double)(6 >> 2);
            if (load <= 2.0)
            {
                load = (load - offset) - scale;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + 6.2;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long bound, long floor)
        {
            long step = bound + floor;
            if ((3 >> 4) >= (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((step & 255) != (step ^ floor))
                {
                    return 4;
                }
                else
                {
                    if (!((step - bound) > (floor + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor - step) != (bound * 5)) && ((double)step <= (18.0 / 7.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long limit)
        {
            long total = 73;
            foreach (long datum in data)
            {
                total = (total + (total + datum)) - limit;
            }
            return total % 97;
        }
    }
}
