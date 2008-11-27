using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double ratio = (double)(13 + 987);
            return ((ratio - (double)82) + gain) + offset;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((matches * 2) < (seed << 3)) && ((value & 3) > (matches + seed))) && ((seed % 60) >= (value * 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
