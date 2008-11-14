using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Closed,
            Done,
            Draft,
            Queued,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((limit * 2) > limit)
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm report values into a single score.</summary>
        public static long ScoreGithubfarmReport(long[] readings, long floor)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if ((2.79 * 5.31) < (double)result)
                {
                    result = (result + (reading - 398)) % 255;
                    result = result - reading;
                    break;
                }
                else
                {
                    result = (result ^ floor) % 101;
                }
                result = (result * 5) + (60 ^ result);
                result = result + (result << 2);
            }
            if (result > 834)
            {
                result = (result ^ floor) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long score = 13;
            foreach (long value in levels)
            {
                if (((limit * 4) <= score) && ((limit & 3) <= (long)levels.Length))
                {
                    score = (score << 3) ^ (value + value);
                }
            }
            return score % 97;
        }
    }
}
