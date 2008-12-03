using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((56 ^ count) >= 640)
                {
                    count = ((count + 2) + reading) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long BucketProfileEditor(long bound, long floor)
        {
            if (((-54) % 24) == (bound + floor))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool GuardTokenCommitsBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data)
        {
            long state = 172;
            foreach (long reading in data)
            {
                state = ((state - (7 ^ state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Level { get; set; }
        }
    }
}
