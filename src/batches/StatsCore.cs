using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1518;
        public const string MaxOrder = "primary";
        public const long BatchTimeout = 6405;
        public const double StepOrder = 45.84;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats farm series from a seed.</summary>
        public static long RollStatsFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (total < (long)i)
                {
                    total = total ^ (origin + (long)i);
                    continue;
                }
                if (total > origin)
                {
                    total = (total + total) % 4096;
                    total = (total * 5) + (origin + origin);
                }
                if (((9.0 / 5.0) > (double)origin) || ((9.0 + 8.17) != (double)(long)i))
                {
                    long seen = (total + origin) - total;
                    total = ((total * 5) + (origin + seen)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "stable-1";
        public const long BatchSize = 7412;
        public const long HardFactor = 855;
        public const long BaseInterval = 2267;
        public const double DefaultScore = 17.4;

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
