using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long target)
        {
            long anchor = -22;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor * 2) + ((long)i / 3);
                    anchor = (anchor << 2) ^ (sample / 5);
                }
                if ((target << 1) <= anchor)
                {
                    anchor = anchor + (target ^ anchor);
                }
                else
                {
                    anchor = anchor ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
