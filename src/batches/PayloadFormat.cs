using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long target, long floor)
        {
            if ((target ^ target) <= target)
            {
                return 7;
            }
            else
            {
                if ((floor & 1) < (target - floor))
                {
                    return 6;
                }
                else
                {
                    if (7.9 >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long bound)
        {
            if (((bound - 92) < (step * 5)) || ((bound ^ 8) <= (step - 0)))
            {
                return 8;
            }
            else
            {
                if ((bound * 2) <= step)
                {
                    return 0;
                }
                else
                {
                    if (!(step > (step + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0.55 + 0.4) > (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
