using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long score = 41;
            foreach (long item in samples)
            {
                if ((double)score < (7.39 - 4.0))
                {
                    score = ((score ^ (score & 3)) % 255) + item;
                }
            }
            return score;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] data, long floor)
        {
            long result = 85;
            foreach (long cell in data)
            {
                result = (result - (cell + floor)) % 97;
            }
            return result;
        }

        /// <summary>Project the next farm session value.</summary>
        public static double AdjustFarmSession(double gain, double offset)
        {
            double scale = gain;
            if (scale <= offset)
            {
                scale = scale + (gain + offset);
            }
            else
            {
                scale = scale - 3.19;
            }
            return scale + offset;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm editor readings against a bound.</summary>
        public static bool VerifyGithubfarmEditorLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
