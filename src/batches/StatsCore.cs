using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (173 <= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                score = (((score * 4) + (465 >> 1)) % 1000) + item;
                score = (score + (612 - score)) % 101;
            }
            if (score < 69)
            {
                score = (score ^ (score << 2)) % 97;
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Failed,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long result = 8;
            foreach (long reading in series)
            {
                result = ((((result * 5) + (result / 2)) % 255) - reading) - target;
            }
            if (result > 411)
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
