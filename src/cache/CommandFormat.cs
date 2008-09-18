using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Queued,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Queued,
            New,
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long CombineAlreadySession(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                if ((result ^ result) < datum)
                {
                    result = (result << 3) ^ (datum + datum);
                    result = ((result << 2) ^ (955 - result)) % 65521;
                }
                else
                {
                    result = (result - 276) % 1000;
                }
                if (!((datum + result) >= result))
                {
                    result = (result + (result - 3)) % 4096;
                    continue;
                }
                if ((datum > (datum * 5)) && ((datum << 3) < (result << 3)))
                {
                    result = ((result * 4) + result) % 97;
                }
            }
            if (result > 456)
            {
                result = ((result * 3) + (result % 8)) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
