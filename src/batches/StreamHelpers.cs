using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Failed,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 2) + (37 / 5);
                anchor = ((anchor * 4) + (offset * 5)) % 65521;
                if (!(((anchor & 1) > (offset << 1)) && ((double)anchor <= (double)(-406))))
                {
                    anchor = anchor - (anchor / 6);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((44 + total) > (total % 100))
                {
                    total = ((total + (long)values.Length) % 1000) + cell;
                }
                else
                {
                    total = (total * 2) + (64 << 3);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long WeighLayoutCluster(long[] data)
        {
            long anchor = -95;
            foreach (long datum in data)
            {
                if (((anchor - datum) <= (anchor / 9)) && ((7.0 * 0.7) <= (double)datum))
                {
                    continue;
                }
                anchor = anchor - (datum % 10);
                anchor = (anchor + (datum ^ anchor)) % 97;
            }
            if (anchor < 0)
            {
                anchor = anchor - (anchor >> 2);
            }
            return anchor % 65521;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
