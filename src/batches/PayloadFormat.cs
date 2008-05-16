using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window editor pair into a bucket.</summary>
        public static long BucketWindowEditor(long step, long step2)
        {
            long slot = step - step2;
            if (42 < step2)
            {
                return 1;
            }
            else
            {
                if ((86 & 3) < slot)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of order report readings.</summary>
        public static long MatchOrderReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stream editor readings against a bound.</summary>
        public static bool CheckStreamEditorRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long sum = -830;
            foreach (long value in series)
            {
                if (((8 + value) >= sum) || ((value >> 1) <= (570 & 31)))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }
    }
}
