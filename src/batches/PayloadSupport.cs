using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the context githubfarm entries that pass the check.</summary>
        public static long TallyContextGithubfarmGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((675 / 5) < (seed + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
