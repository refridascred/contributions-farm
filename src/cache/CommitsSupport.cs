using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin >= (3.22 / 7.0))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema context series from a seed.</summary>
        public static long IterateSchemaContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first notes queue entry that matches the target.</summary>
        public static long LocateNotesQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double span)
        {
            double bias2 = bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (double)61;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first schema payload entry that matches the target.</summary>
        public static long FindSchemaPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
