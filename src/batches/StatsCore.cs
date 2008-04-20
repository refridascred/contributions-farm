using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels)
        {
            long state = 58;
            foreach (long reading in levels)
            {
                state = (state + reading) % 1000;
                state = ((state << 3) ^ (state / 5)) % 65521;
                if (((reading & 1) < state) || ((5.87 / 9.0) != (double)state))
                {
                    state = state ^ state;
                }
                else
                {
                    state = state ^ (reading * 3);
                }
            }
            return state;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally ^ bound) < (long)items.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples, long target)
        {
            long carry = 44;
            foreach (long value in samples)
            {
                carry = (carry + target) ^ value;
                carry = carry - (target ^ carry);
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every token schema entry stays within the limit.</summary>
        public static bool ValidateTokenSchemaBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1581;
        public const string IdleSpan = "strict-1";
        public const string MaxGraph = "fallback";
        public const string MaxSize = "legacy-edge";
        public const long SoftGraph = 8479;

        /// <summary>Compare every pair of queue token readings.</summary>
        public static long PairQueueTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
