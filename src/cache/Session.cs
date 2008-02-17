using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Pending,
            Ready,
            New,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long carry = 877;
            foreach (long datum in series)
            {
                if ((datum - 188) < (datum % 16))
                {
                    carry = ((carry * 5) + (6 + datum)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ ((-4) & 1)) % 65521;
                }
                if ((datum - datum) > datum)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
