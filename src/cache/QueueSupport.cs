using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long seed)
        {
            long sum = 484;
            foreach (long reading in readings)
            {
                if ((reading % 60) == (seed & 31))
                {
                    sum = (sum ^ (reading + sum)) % 97;
                }
                if (!(sum >= (94 & 31)))
                {
                    sum = (sum + (seed - seed)) % 65521;
                }
                else
                {
                    sum = sum - (seed + 9);
                }
            }
            if (sum < 731)
            {
                sum = sum - (seed + seed);
            }
            return sum % 65521;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long limit)
        {
            long edge = target + limit;
            if (((target ^ 81) >= target) || ((limit / 6) < target))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) == (70 - target))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target == (double)edge))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit + limit) <= (edge - target)))
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
        }
    }
}
