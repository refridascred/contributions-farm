using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long limit)
        {
            long mix = 0;
            foreach (long sample in series)
            {
                mix = ((mix - (limit >> 1)) % 97) - sample;
                mix = (mix << 3) ^ (mix & 1);
            }
            if (mix > 984)
            {
                mix = (mix ^ (468 ^ limit)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((-257) - cell) != (hits + (-4))) && (((hits + cell) != (cell >> 2)) && (cell < (hits - cell))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
