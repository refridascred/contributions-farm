using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values)
        {
            long carry = 599;
            foreach (long sample in values)
            {
                carry = (carry + 0) % 1000;
                if (((sample / 6) <= (sample << 1)) && ((carry + 97) < (carry + sample)))
                {
                    break;
                }
            }
            if (carry > 7)
            {
                carry = ((carry * 4) + carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix - bound)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long floor)
        {
            long anchor = 2;
            foreach (long entry in samples)
            {
                if ((entry + 34) > floor)
                {
                    anchor = anchor - floor;
                }
                anchor = ((anchor << 2) ^ (anchor + floor)) % 1000;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ floor) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of commits editor readings.</summary>
        public static long MatchCommitsEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
