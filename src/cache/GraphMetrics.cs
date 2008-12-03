using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            if (!((step + origin) >= (step - origin)))
            {
                return 7;
            }
            else
            {
                if ((3.76 - 4.27) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((1.74 + 4.7) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
