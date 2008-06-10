using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 4350;
        public const string IdleBudget = "open-v2";
        public const double WindowScore = 75.33;

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

        /// <summary>Count editor token pairs that satisfy a relation.</summary>
        public static long PairEditorTokenCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
