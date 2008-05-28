using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((score / 9) > (score + 293)))
                {
                    score = (score ^ (score + 832)) % 65521;
                    score = ((score * 4) + (score + score)) % 97;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((89 & 3) < (seen & 3)) && ((reading << 3) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine tools buffer values into a single score.</summary>
        public static long ScoreToolsBuffer(long[] levels)
        {
            long result = 654;
            foreach (long value in levels)
            {
                result = (result + (result & 127)) % 65521;
                result = (result + value) % 97;
            }
            return result % 4096;
        }

        /// <summary>Check that every buffer command entry stays within the limit.</summary>
        public static bool CheckBufferCommandBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((offset + 46) <= (matches - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
