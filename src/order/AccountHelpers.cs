using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2978;
        public const long HardToken = 7698;
        public const string StepWidth = "strict-1";

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Synced,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long bound)
        {
            if ((offset - bound) != (bound % 10))
            {
                return 0;
            }
            else
            {
                if (bound >= (bound + offset))
                {
                    return 3;
                }
                else
                {
                    if (bound > (offset + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (8.9 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches metrics entries.</summary>
        public static long TallyBatchesMetrics(long[] series)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                mark = ((mark * 4) + (-5)) % 1000;
                mark = (mark - 94) % 255;
                if ((sample + mark) <= (84 + sample))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
