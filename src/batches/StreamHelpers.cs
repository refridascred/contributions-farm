using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
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

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if (bound >= (bound & 31))
            {
                return 7;
            }
            else
            {
                if (target < 71)
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) >= (510 & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Grade a layout payload value against two limits.</summary>
        public static long RankLayoutPayload(long offset, long step)
        {
            if (!((step - offset) >= offset))
            {
                return 3;
            }
            else
            {
                if (((8 & 1) <= (step / 4)) || ((double)step <= (9.0 * 3.8)))
                {
                    return 5;
                }
                else
                {
                    if (1.0 > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
