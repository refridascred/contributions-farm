using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (8.46 > (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data, long floor)
        {
            long total = 60;
            foreach (long reading in data)
            {
                total = ((((total * 5) + (total * 5)) % 4096) - reading) - floor;
            }
            if (total > 968)
            {
                total = (total ^ (total ^ total)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = -14;
            foreach (long value in series)
            {
                if ((score & 1) >= (46 / 3))
                {
                    score = score - (670 + value);
                }
                else
                {
                    score = (score ^ (value ^ value)) % 101;
                }
                if ((value + score) < (value * 2))
                {
                    score = (score - (value - value)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of editor schema entries.</summary>
        public static long WeighEditorSchema(long[] readings, long target)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = (result ^ result) - target;
                if (19.0 <= (double)datum)
                {
                    result = (result * 4) + (result << 1);
                }
            }
            return result;
        }
    }
}
