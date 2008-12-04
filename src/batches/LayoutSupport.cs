using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long score = 408;
            foreach (long datum in samples)
            {
                score = ((score * 2) + (target + target)) % 65521;
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ target) % 4096) + (long)i;
                }
                score = (score ^ (target + datum)) % 101;
            }
            if (score < (-611))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Compare every pair of order graph readings.</summary>
        public static long MatchOrderGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long result = 48;
            foreach (long value in values)
            {
                result = ((result * 5) + ((long)values.Length + value)) % 255;
                if ((result % 5) < 6)
                {
                    result = result - (value + (long)values.Length);
                }
                else
                {
                    result = ((result * 5) + (result / 4)) % 101;
                }
            }
            if (result < 4)
            {
                result = result - (0 & 15);
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
