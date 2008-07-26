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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
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

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] items, long step)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                if (step < (mark - mark))
                {
                    mark = (mark + mark) ^ reading;
                }
                mark = (mark * 5) + (mark + step);
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] items, long limit)
        {
            long mix = 315;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ (cell / 9)) + limit;
            }
            return mix % 97;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
