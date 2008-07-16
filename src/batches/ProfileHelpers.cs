using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - hits) != (hits & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count record filter pairs that satisfy a relation.</summary>
        public static long CompareRecordFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)bound > (4.5 + 6.0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
