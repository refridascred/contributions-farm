using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (reading / 4)) % 255) - origin;
                if (mix > (reading + 17))
                {
                    mix = (mix - (mix << 3)) % 97;
                }
                if ((reading + 615) == (reading >> 2))
                {
                    break;
                }
            }
            if (mix > (-1))
            {
                mix = ((mix * 2) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Idle,
            Synced,
            New,
        }

        /// <summary>Locate a window entry reading by value.</summary>
        public static long LookupWindowEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context buffer series from a seed.</summary>
        public static long StepContextBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed - sum) > ((long)i >> 5))
                {
                    sum = ((sum * 4) + (8 - seed)) % 4096;
                }
                if (!(((58 % 64) != (long)i) || (sum >= (6 - seed))))
                {
                    sum = (sum ^ ((long)i + seed)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                if ((2 - mix) != (mix ^ 4))
                {
                    long gap = (mix / 9) * 5;
                    mix = mix - (gap ^ gap);
                }
                if (!(((mix - mix) == ((long)samples.Length + mix)) && (((-9) - item) < (mix - item))))
                {
                    mix = mix + (mix << 2);
                }
                if (mix > (mix * 3))
                {
                    mix = mix + (mix % 5);
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((2 >> 2) == (datum & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
