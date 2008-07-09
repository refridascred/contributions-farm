using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Derive the next booking value from a seed.</summary>
        public static long StepBooking(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long mix = 50;
            foreach (long item in data)
            {
                if ((item + mix) == (item - item))
                {
                    mix = mix + (item + item);
                }
            }
            if (mix > (-857))
            {
                mix = (mix + (mix % 2)) % 255;
            }
            return mix;
        }
    }
}
