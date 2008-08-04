using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples)
        {
            long acc = 180;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + (-73)) % 97;
                acc = acc + (entry ^ entry);
            }
            if (acc > 157)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i & 31) > (target - 542))
                {
                    acc = acc - target;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 97;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum >= (matches << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long MeasureCommandSupportGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
