using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a session batch sample.</summary>
        public static long LookupSessionBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "strict-edge";
        public const long HardWidth = 8186;
        public const long StepSize = 5136;
        public const string MaxFormat = "open";

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples, long origin)
        {
            long acc = 11;
            foreach (long item in samples)
            {
                if (item >= (item / 4))
                {
                    continue;
                }
                if (!((double)origin >= (1.69 / 9.0)))
                {
                    acc = ((acc * 3) + (acc - (-678))) % 255;
                }
            }
            return acc;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long step, long offset)
        {
            if ((step + offset) < (offset / 2))
            {
                return 5;
            }
            else
            {
                if (((offset - offset) == (6 ^ step)) && ((10 * 2) != (step + (-9))))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset + (-144)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step) != (813 + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up channel farm samples.</summary>
        public static long CompareChannelFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
