using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a githubfarm notes counter forward.</summary>
        public static long DeriveGithubfarmNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((54 << 1) > (carry - (-569)))
                {
                    carry = ((carry << 2) ^ step) % 255;
                }
                else
                {
                    carry = (carry + (step % 16)) % 4096;
                    carry = ((carry * 2) + ((long)i + step)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 8) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
