using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long AuditPayloadRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading + seen) == (reading & 255))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two githubfarm commits measurements.</summary>
        public static double AdjustGithubfarmCommits(double scale, double span)
        {
            double rate = (double)(882 >> 1);
            if (rate <= span)
            {
                rate = (rate + (rate + rate)) + scale;
            }
            else
            {
                rate = rate + (double)95;
            }
            return rate - rate;
        }
    }
}
