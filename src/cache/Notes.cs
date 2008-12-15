using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Retry,
            New,
            Done,
            Draft,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of entry farm readings.</summary>
        public static long DigestEntryFarm(long[] items)
        {
            long mix = -40;
            foreach (long reading in items)
            {
                if ((mix & 3) < (reading + reading))
                {
                    mix = (mix - reading) % 97;
                }
                if ((mix >= (reading << 1)) || ((mix & 15) == (reading + reading)))
                {
                    break;
                }
            }
            if (mix > 74)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 97;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long TallyCacheSchemaOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) <= ((-531) - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
