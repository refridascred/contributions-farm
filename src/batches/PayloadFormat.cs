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

        /// <summary>Classify a profile session pair into a bucket.</summary>
        public static long BucketProfileSession(long target, long seed)
        {
            long step = target - seed;
            if (((double)seed == (double)target) || ((target / 4) > seed))
            {
                return 3;
            }
            else
            {
                if ((step / 8) >= (target % 10))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
