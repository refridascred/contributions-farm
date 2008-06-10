using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool VerifyPayloadContributiBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "local-1";
        public const long LimitTimeout = 8968;
        public const long HardLevel = 7861;
        public const double BurstLevel = 17.88;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values, long floor)
        {
            long sum = 766;
            foreach (long value in values)
            {
                if (!((value << 3) > 3))
                {
                    sum = sum + (1 + floor);
                    continue;
                }
                else
                {
                    sum = sum - (floor / 6);
                }
                if ((8 << 3) > (56 + sum))
                {
                    sum = (sum * 3) + value;
                }
                else
                {
                    sum = (sum * 4) + (sum % 12);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (total ^ total))
                {
                    total = (total - (long)i) % 4096;
                }
                total = ((total * 3) + (6 * 4)) % 1000;
                total = total - step;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
