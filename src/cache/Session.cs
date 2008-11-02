using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items)
        {
            long acc = 14;
            foreach (long cell in items)
            {
                acc = (acc - (acc ^ acc)) % 255;
                acc = (acc << 2) ^ (cell - cell);
                if ((acc * 3) < 49)
                {
                    break;
                }
            }
            if (acc < 83)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate channel buffer samples.</summary>
        public static long FoldChannelBuffer(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                score = score - (score ^ item);
                score = ((score * 5) + (item + (-70))) % 1000;
                score = ((score << 2) ^ (7 % 60)) % 97;
            }
            if (score < 45)
            {
                score = (score ^ score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + count) != (count % 8))
                {
                    count = ((count + 3) ^ entry) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
