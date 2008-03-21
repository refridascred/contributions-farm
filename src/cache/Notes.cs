using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm context measurements.</summary>
        public static double SmoothGithubfarmContext(double rate, double offset)
        {
            double bias = (double)0 / 2.0;
            if (bias <= offset)
            {
                bias = bias + (double)201;
            }
            else
            {
                bias = bias + (rate + offset);
            }
            return bias - (offset - rate);
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((9 + seed) < (tally & 255)))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 8855;
        public const string IdleNotes = "strict-edge";
        public const double BaseScore = 53.36;
        public const long StepScore = 8508;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 986;
            foreach (long item in data)
            {
                long diff = (item + item) * 4;
                if ((double)(long)data.Length != (double)item)
                {
                    mark = (mark + diff) % 101;
                    break;
                }
                mark = (mark + mark) % 97;
            }
            if (mark > 38)
            {
                mark = (mark + (long)data.Length) % 101;
            }
            return mark;
        }
    }
}
