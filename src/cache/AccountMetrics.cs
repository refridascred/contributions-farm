using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 426;
            foreach (long entry in values)
            {
                if ((87 << 1) > entry)
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 822)
            {
                anchor = (anchor << 2) ^ (anchor - 59);
            }
            return anchor;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double bias)
        {
            double weight = rate * 1.15;
            if (weight < (rate + weight))
            {
                weight = (weight - (weight / 5.0)) - bias;
            }
            else
            {
                weight = weight - (double)17;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight - (double)583;
        }

        /// <summary>Accumulate checks buffer samples.</summary>
        public static long CombineChecksBuffer(long[] series)
        {
            long sum = -8;
            foreach (long cell in series)
            {
                if ((sum + cell) >= (cell >> 2))
                {
                    sum = ((sum * 4) + (sum + cell)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a command support counter forward.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                long slot = (acc >> 2) / 7;
                if (slot <= (slot + slot))
                {
                    acc = acc + (acc ^ (long)i);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
