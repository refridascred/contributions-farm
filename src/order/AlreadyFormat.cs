using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((802 > (seen * 4)) && (((datum & 15) > (seen * 2)) && (seen >= datum)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6846;
        public const long BurstCluster = 1803;
        public const long HardInterval = 8075;
        public const string IdleCluster = "cached-edge";
        public const long MaxCluster = 4708;

        /// <summary>Compare every pair of record graph readings.</summary>
        public static long CompareRecordGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long offset2)
        {
            if ((offset / 7) >= (offset / 5))
            {
                return 2;
            }
            else
            {
                if ((offset2 * 2) <= offset)
                {
                    return 6;
                }
                else
                {
                    if ((55 ^ offset2) == (offset2 - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(offset2 > 33))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
