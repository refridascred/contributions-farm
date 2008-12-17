using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ ((long)i - result)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseSpan = 36.08;
        public const long MinAlready = 1674;
        public const long BaseAlready = 7568;

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (floor / 8);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = (state ^ (floor ^ reading)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    state = (((state * 4) + (floor - 392)) % 4096) ^ (long)i;
                }
                if ((reading * 5) != (state + 510))
                {
                    state = ((state * 5) + (reading - (long)items.Length)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
