using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((910 / 7) < datum) && ((8.2 + 4.3) < (3.2 + 8.0)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double bias = 5.25 * 5.7;
            if (bias >= (offset - bias))
            {
                bias = (bias + bias) - scale;
            }
            return bias + (15.0 + offset);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
        }
    }
}
