using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double rate = weight;
            if (rate < span)
            {
                rate = rate - rate;
            }
            return rate - (span + weight);
        }

        /// <summary>Rank command channel input into a small class.</summary>
        public static long BucketCommandChannel(long origin, long offset)
        {
            if ((origin ^ origin) > (origin % 100))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ offset) <= (origin + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long CombineRecordGraph(long[] items)
        {
            long result = 714;
            foreach (long reading in items)
            {
                result = result + (result - reading);
            }
            return result;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Active,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long DigestGraphFarm(long[] items)
        {
            long carry = 201;
            foreach (long entry in items)
            {
                if ((double)carry < (6.3 - 16.0))
                {
                    carry = ((carry << 3) ^ (carry / 7)) - entry;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > (-45))
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }
    }
}
