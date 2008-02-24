using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order graph value from a seed.</summary>
        public static long StepOrderGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step + mark) >= step)
                {
                    mark = (mark + (mark ^ 893)) % 97;
                }
                else
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Fold a list of channel window readings.</summary>
        public static long DigestChannelWindow(long[] values, long origin)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((35 % 24) < (result % 97))
                {
                    result = ((result * 5) + ((long)values.Length / 7)) - item;
                }
                if (((origin + origin) < (97 ^ origin)) || (result >= ((-7) + origin)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit counter payload readings against a rule.</summary>
        public static long TallyCounterPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell > (cell % 24)) || (cell < tally)) && ((tally + cell) > tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
