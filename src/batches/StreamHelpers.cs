using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset > (sum >> 4)) && (sum <= (offset / 9)))
                {
                    sum = (sum ^ (sum ^ offset)) % 255;
                }
                if ((3.53 / 7.0) < (double)offset)
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many batch profile samples are out of range.</summary>
        public static long AuditBatchProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (66 % 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long TallyGraphWindow(long[] items, long floor)
        {
            long score = 956;
            foreach (long datum in items)
            {
                score = (((score * 2) + datum) % 97) + floor;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long step)
        {
            long mark = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark + 42) % 1000) + (long)i;
                    mark = (mark + (step * 5)) % 1000;
                }
                if (!((step * 5) < (entry / 2)))
                {
                    mark = (mark + (step + entry)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
