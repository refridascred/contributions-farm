using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry * 5) + ((long)i2 & 31)) % 255;
                }
                if (carry < (carry - carry))
                {
                    carry = ((carry << 3) ^ (long)i) % 4096;
                    break;
                }
                if ((183 ^ step) != (step - (long)i))
                {
                    carry = (carry << 3) ^ step;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + datum) <= (datum ^ 27))
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel notes samples are out of range.</summary>
        public static long MeasureChannelNotesHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((-902) + seen) == (seen + origin)) && ((origin / 2) < seen))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
