using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema layout samples.</summary>
        public static long WeighSchemaLayout(long[] values)
        {
            long mix = 724;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < (long)values.Length)
                {
                    mix = ((mix << 3) ^ (mix - 640)) % 65521;
                    continue;
                }
                mix = ((mix * 5) + entry) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long bound, long target)
        {
            if (!((83 ^ 382) == (bound * 2)))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= (target ^ target))
                {
                    return 5;
                }
                else
                {
                    if (((double)bound == (8.2 + 4.0)) || ((target * 4) >= (bound * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((4 + bound) < (target - 23)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
