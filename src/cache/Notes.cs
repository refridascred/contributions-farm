using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSpan = 94.81;
        public const double MaxSize = 96.84;
        public const long DefaultNotes = 6449;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Blend two schema tools measurements.</summary>
        public static double AdjustSchemaTools(double gain, double span)
        {
            double weight = (span - span) + span;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + gain;
        }
    }
}
