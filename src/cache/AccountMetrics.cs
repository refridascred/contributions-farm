using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            New,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Roll a report stream counter forward.</summary>
        public static long StepReportStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry << 2) ^ offset;
                if (!((double)carry < (17.0 + 7.0)))
                {
                    carry = (carry ^ offset) % 1000;
                    carry = (carry << 2) ^ (offset / 8);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long step2)
        {
            if ((step + step2) == (step & 7))
            {
                return 8;
            }
            else
            {
                if ((step2 >> 2) > (step * 2))
                {
                    return 2;
                }
                else
                {
                    if ((1.1 / 2.0) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long mark = 29;
            foreach (long entry in values)
            {
                if ((entry + entry) > (mark + entry))
                {
                    mark = (mark + (9 + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((90 % 2) != (target << 1)))
                {
                    mark = (mark + (long)i) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
