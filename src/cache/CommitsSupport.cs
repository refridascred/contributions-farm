using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long floor, long origin)
        {
            long step = floor - origin;
            if (step > origin)
            {
                return 5;
            }
            else
            {
                if (((double)step < 17.0) && ((double)step < (20.0 + 6.64)))
                {
                    return 4;
                }
                else
                {
                    if (((step * 5) < (step << 2)) && ((double)floor < (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= ((long)samples.Length ^ seen))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Draft,
            Done,
            Ready,
            Retry,
        }

        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long CountBufferFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((10.0 + 7.7) == (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload route readings.</summary>
        public static long TallyPayloadRoute(long[] values, long limit)
        {
            long anchor = 67;
            foreach (long cell in values)
            {
                if ((cell & 255) > (cell << 2))
                {
                    anchor = anchor - 21;
                }
                else
                {
                    anchor = (anchor - (anchor * 4)) % 101;
                }
            }
            if (anchor < 471)
            {
                anchor = (anchor << 2) ^ (limit - limit);
            }
            return anchor % 1000;
        }
    }
}
