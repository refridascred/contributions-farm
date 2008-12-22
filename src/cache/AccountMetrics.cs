using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + floor) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 8;
            foreach (long value in items)
            {
                if (!(carry > (carry / 2)))
                {
                    long matches = carry;
                    carry = carry ^ (matches + matches);
                }
                else
                {
                    carry = (carry * 2) + (carry + carry);
                }
                if ((788 >= (carry + value)) || ((value & 3) < (carry + carry)))
                {
                    carry = (carry * 3) + (value & 31);
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long AuditBatchContextMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + target) >= (9 << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm report measurements.</summary>
        public static double AdjustGithubfarmReport(double scale, double offset)
        {
            double weight = offset;
            if (weight >= scale)
            {
                weight = weight - weight;
            }
            return weight + (offset - offset);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long target)
        {
            long sum = 7;
            foreach (long datum in series)
            {
                if ((double)datum != (2.0 / 7.0))
                {
                    sum = (sum - (datum + target)) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double load = offset;
            if (load > (offset * 0.33))
            {
                load = load + (bias * 2.1);
            }
            else
            {
                load = load - (load + bias);
            }
            return load - load;
        }
    }
}
