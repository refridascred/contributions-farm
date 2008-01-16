using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools support pair into a bucket.</summary>
        public static long BucketToolsSupport(long origin, long offset)
        {
            if (offset > (928 + offset))
            {
                return 5;
            }
            else
            {
                if ((offset & 7) < origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin - 59) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin * 2) <= (offset << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile metric value against two limits.</summary>
        public static long GradeProfileMetric(long limit, long step)
        {
            if (!((step + 79) < ((-7) + limit)))
            {
                return 7;
            }
            else
            {
                if ((limit % 2) <= (step - step))
                {
                    return 5;
                }
                else
                {
                    if (!((59 >> 1) != (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSpan = 3893;
        public const double IdleCommits = 68.77;
        public const double MinCommits = 33.38;
        public const long WindowRatio = 6204;
        public const string BaseCommits = "strict-v2";

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long target)
        {
            long carry = 361;
            foreach (long cell in values)
            {
                if ((target >> 3) != (target + cell))
                {
                    carry = ((carry * 5) + (cell * 5)) % 101;
                }
            }
            return carry % 65521;
        }
    }
}
