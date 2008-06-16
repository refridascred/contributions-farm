using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of command channel entries.</summary>
        public static long TotalCommandChannel(long[] data, long offset)
        {
            long score = 1;
            foreach (long reading in data)
            {
                if (((score + score) <= (score + 4)) || ((score + score) <= 488))
                {
                    score = (((score * 3) + (long)data.Length) % 101) - reading;
                }
            }
            if (score > 26)
            {
                score = (score ^ (offset % 12)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Count the already token entries that pass the check.</summary>
        public static long CountAlreadyTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - 756) < 2)
                {
                    matches = (matches + 2) ^ value;
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
