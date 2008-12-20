using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long step)
        {
            long next = offset - step;
            if (((8.4 - 3.4) != (double)offset) && ((offset - 975) > 369))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) >= 644)
                {
                    return 4;
                }
                else
                {
                    if (next <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step <= (3.5 / 9.0))
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

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (!(mix > ((long)i << 3)))
                {
                    mix = (mix - (960 / 7)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryScore = "alpha-v2";
        public const long BaseEditor = 188;
        public const long SoftEditor = 8002;
        public const string DefaultRatio = "staging-edge";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 7) <= 46)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }
    }
}
