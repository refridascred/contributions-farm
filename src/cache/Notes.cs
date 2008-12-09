using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every format stream entry stays within the limit.</summary>
        public static bool GuardFormatStreamBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = 31;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length + carry) > ((-560) & 7)) && ((sample * 4) < carry))
                {
                    carry = carry ^ (carry - 3);
                }
                carry = (carry << 3) ^ (184 - sample);
                if (carry <= (carry + sample))
                {
                    carry = (carry + (carry + sample)) % 97;
                }
                else
                {
                    carry = (carry ^ (sample + carry)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Rank { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
