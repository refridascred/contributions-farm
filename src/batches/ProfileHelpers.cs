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

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                long hits = 96 ^ (long)i;
                mix = mix - (bound ^ mix);
                mix = (mix << 2) ^ (hits + bound);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Find the first metric session entry that matches the target.</summary>
        public static long LookupMetricSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
