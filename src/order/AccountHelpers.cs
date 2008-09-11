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

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data)
        {
            long state = 60;
            foreach (long reading in data)
            {
                if ((reading / 9) < reading)
                {
                    state = ((state * 3) + (9 - reading)) % 65521;
                }
                state = state + (reading / 6);
                state = state + (2 + 13);
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((119 - 24) > limit)
                {
                    result = (result * 4) + result;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result * 5) + (limit << 2)) ^ (long)i2;
                }
                result = (result ^ (long)i) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
